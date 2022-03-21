public enum ND_ERROR
{
	ND_E_NO_ERROR,
	ND_E_TEST_NOT_RUN,
	ND_E_NO_INTERFACE,
	ND_E_NO_INTERFACE_WITH_GATEWAY,
	ND_E_NO_INTERFACE_WITH_ROUTE,
	ND_E_TIMEOUT,
	ND_E_CANT_ICMP,
	ND_E_CANT_RESOLVE_VIVOX_UDP_SERVER,
	ND_E_CANT_RESOLVE_ROOT_DNS_SERVER,
	ND_E_CANT_CONVERT_LOCAL_IP_ADDRESS,
	ND_E_CANT_CONTACT_STUN_SERVER_ON_UDP_PORT_3478,
	ND_E_CANT_CREATE_TCP_SOCKET,
	ND_E_CANT_LOAD_ICMP_LIBRARY,
	ND_E_CANT_FIND_SENDECHO2_PROCADDR,
	ND_E_CANT_CONNECT_TO_ECHO_SERVER,
	ND_E_ECHO_SERVER_LOGIN_SEND_FAILED,
	ND_E_ECHO_SERVER_LOGIN_RECV_FAILED,
	ND_E_ECHO_SERVER_LOGIN_RESPONSE_MISSING_STATUS,
	ND_E_ECHO_SERVER_LOGIN_RESPONSE_FAILED_STATUS,
	ND_E_ECHO_SERVER_LOGIN_RESPONSE_MISSING_SESSIONID,
	ND_E_ECHO_SERVER_LOGIN_RESPONSE_MISSING_SIPPORT,
	ND_E_ECHO_SERVER_LOGIN_RESPONSE_MISSING_AUDIORTP,
	ND_E_ECHO_SERVER_LOGIN_RESPONSE_MISSING_AUDIORTCP,
	ND_E_ECHO_SERVER_LOGIN_RESPONSE_MISSING_VIDEORTP,
	ND_E_ECHO_SERVER_LOGIN_RESPONSE_MISSING_VIDEORTCP,
	ND_E_ECHO_SERVER_CANT_ALLOCATE_SIP_SOCKET,
	ND_E_ECHO_SERVER_CANT_ALLOCATE_MEDIA_SOCKET,
	ND_E_ECHO_SERVER_SIP_UDP_SEND_FAILED,
	ND_E_ECHO_SERVER_SIP_UDP_RECV_FAILED,
	ND_E_ECHO_SERVER_SIP_TCP_SEND_FAILED,
	ND_E_ECHO_SERVER_SIP_TCP_RECV_FAILED,
	ND_E_ECHO_SERVER_SIP_NO_UDP_OR_TCP,
	ND_E_ECHO_SERVER_SIP_NO_UDP,
	ND_E_ECHO_SERVER_SIP_NO_TCP,
	ND_E_ECHO_SERVER_SIP_MALFORMED_TCP_PACKET,
	ND_E_ECHO_SERVER_SIP_UDP_DIFFERENT_LENGTH,
	ND_E_ECHO_SERVER_SIP_UDP_DATA_DIFFERENT,
	ND_E_ECHO_SERVER_SIP_TCP_PACKETS_DIFFERENT,
	ND_E_ECHO_SERVER_SIP_TCP_PACKETS_DIFFERENT_SIZE,
	ND_E_ECHO_SERVER_LOGIN_RECV_FAILED_TIMEOUT,
	ND_E_ECHO_SERVER_TCP_SET_ASYNC_FAILED,
	ND_E_ECHO_SERVER_UDP_SET_ASYNC_FAILED,
	ND_E_ECHO_SERVER_CANT_RESOLVE_NAME
}
