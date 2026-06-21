from mitmproxy import http
from mitmproxy import ctx

def load(loader):
    ctx.options.connection_strategy = "lazy"
    ctx.options.upstream_cert = False
    ctx.options.ssl_insecure = True
    ctx.options.allow_hosts = ['sunborngame.com']
    
def request(flow: http.HTTPFlow) -> None:
    if "sunborngame.com" in flow.request.pretty_url:
        flow.request.host = "127.0.0.1"
        flow.request.port = 443