# HttpClientCoreClrRepro

- To run the WebApp, you can do `dnx web` from the project directory

- To run the client, you can do `dnx run` from the project directory
  NOTE: make sure to install both the Clr and CoreClr version of DNXs on your machine and flip between these 2 to see that HttpClient on CoreClr does not return the cookies which were ealrier sent in a redirect response
