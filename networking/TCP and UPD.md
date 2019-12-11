## Transport Layer Protocol
* Transmission control protocol.
  1. Tcp is much like a 3 way handshake 
  2. Client sends syn message to server 
  3. Server sends message syn ack to client (syn recieved and acknowledged)
  4. Now Client sends message (Ack - acknowledged) to server 
  5. Now the session is established and once session is established we can send HTTP message from client to server
      Hey send me the website with ulr address (Ex: www.yahoo.com) etc...)
      and server responds by saying here is the website you wanted 
      so  we have used layer 4 to establish the session 
      and layer 7 to send the original message 
   6. So with TCP we have a way of navigating the conversation like Yes I got what you wnat , no please repeat one more time
   what you want..

## Transort layer addressing: Port Numbers
1. At transport layer we are using port numbers To identify typically an application layer protocol that is beeing used.
2. In TCP or UDP there is always a souce port number and destination port number, in the segment header
3. These port numbers are devided in to differnt catogiries 
    * Server port numbers (Well known and Registered port numbers)
    * Client port numbers (Ephermeral port numbers - Ephermeral means temporary port numbers)
    * Well known port numbers (0 -1023)
    * Registerd port numbers (1024 - 49,151)
    * Ephermeral port numbers (49,152 - 65,535)

  
* User Datagram Protocol.

### Protocol hirarchy:
*

### how application layer protocol related to Tranport layer protocol and network layer protocol:
*
