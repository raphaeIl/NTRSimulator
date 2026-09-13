"""Validate translation arguments, currency values and functional rich-text tags."""
import collections
import re

CHINESE = re.compile(r"[\u3400-\u9fff]")
PLACEHOLDER = re.compile(r"(?<!\{)\{(\d+)(?:,[^{}:]+)?(?::[^{}]+)?\}(?!\})|%\d*\$?[sdif]|\[VAL\d+\]")
TAG = re.compile(r"</?(?:color|size|b|i|u|s|sprite|link|br|alpha|voffset|font|material|space|cspace|mspace|align|indent|line-height|nobr|mark|sub|sup)(?:=[^<>]*)?\s*/?>", re.I)
STYLE_NAMES = {"color", "size", "b", "i", "u", "s", "mark", "sub", "sup"}


def formatting_compatible(source, english):
    # Typography may differ in the publisher's localization. Only permit those
    # differences when all style pairs balance and functional tags are identical.
    def inspect(text):
        stack, critical = [], []
        for token in TAG.findall(text):
            name = re.match(r"</?(\w+)", token)[1].lower()
            if name not in STYLE_NAMES:
                critical.append(token)
            elif token.startswith("</"):
                if not stack or stack.pop() != name:
                    return False, critical
            else:
                stack.append(name)
        return not stack, critical
    if collections.Counter(TAG.findall(source)) == collections.Counter(TAG.findall(english)):
        return True  # Includes intentionally partial rich-text fragments.
    source_ok, source_critical = inspect(source)
    english_ok, english_critical = inspect(english)
    return source_ok and english_ok and collections.Counter(source_critical) == collections.Counter(english_critical)


def tokens(text):
    # This one known .NET date format changes only literal separators, retaining
    # the same year/month/day/hour/minute/second fields and argument index.
    text = re.sub(r"\{(\d+):yyyy年MM月dd日 HH时mm分ss秒\}", r"{\1:yyyy-MM-dd HH:mm:ss}", text)
    return collections.Counter(m.group(0) for m in PLACEHOLDER.finditer(text))


def numeric_tokens(text):
    text = PLACEHOLDER.sub("", TAG.sub("", text))
    text = re.sub(r"\b(\d{1,2}):00\b", r"\1", text)
    return collections.Counter(re.findall(r"(?<![A-Za-z])\d+(?:\.\d+)?", text))


def compatible(source, english):
    if not english.strip() or CHINESE.search(english):
        return False, "missing English"
    if tokens(source) != tokens(english):
        return False, "placeholder mismatch"
    # Currency strings require literal number agreement. Elsewhere the official
    # localization legitimately renders Chinese numerals as digits, 8-discount as
    # 80%, and weapon names as model numbers. Record those differences for review.
    if re.search(r"人民币|美元|[0-9}]元|[￥¥$]", source) and numeric_tokens(source) != numeric_tokens(english):
        return False, "number mismatch"
    if not formatting_compatible(source, english):
        return False, "formatting mismatch"
    return True, ""
