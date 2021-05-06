# GomokuRpc
(WIP) gRPC microservice-based system used for handling classic board games over the internet.

The idea behind this project is to build a distributed system with separate microservices using *only* gRPC HTTP/2 protocol for intercommunication.
So far the projects structure is as follows:
1. GomokuRpc.WebApi project handling requests from clients - .NET 5 gRPC standalone service
1. GomokuRpc.Core project containing core game logic - .NET 5 gRPC standalone service
2. GomokuRpc.Storage project handling read and write requests (queries/commands maybe?) to the database - .NET 5 gRPC standalone service + EF Core
3. GomokuRpc.Mobile multiproject targeting iOS and Android builds - Xamarin.Forms
4. GomokuRpc.WebClient adapter library for making HTTP/2 calls in .NET Framework-based apps (Xamarin/WPF)
5. GomokuRpc.Contracts shared library used for storing proto files and any common interfaces/models.
