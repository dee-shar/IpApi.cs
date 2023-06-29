#!/bin/bash

api="http://ip-api.com"
user_agent="okhttp/3.12.1"

function get_ip_info() {
	# 1 - ip_address: (string): <ip_address>
	curl --request GET \
		--url "$api/json/$1" \
		--user-agent "$user_agent"
}

function get_own_ip_info() {
	curl --request GET \
		--url "$api/json" \
		--user-agent "$user_agent" \
		--header "content-type: application/json"
}
