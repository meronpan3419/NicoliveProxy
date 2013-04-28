function FindProxyForURL(url, host) {
	
	if(url.indexOf("nicovideo.jp/api/getpublishstatus?") >= 0){
		return "PROXY 127.0.0.1:8080";
	}
	return "DIRECT";
}

