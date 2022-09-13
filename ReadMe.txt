Steps for Project Setup/Run

1: We have created 2 microservices => Account,User

- both contains dockerfile for configuration purpose to build project using docker

2: Main solution contains "docker-compose.yml" that configure both microservices under diffrent ports

3: Now run 2 commands under main solution directory using cmd

docker-compose build
docker-compose up

you'll see 2 services running under docker

4: now configure your routes under OcletAPIGateway file name ocelot.json

that contains "UpstreamPathTemplate" & "DownstreamPathTemplate"

"UpstreamPathTemplate": URI from userside to enter
"DownstreamPathTemplate": Redirect to Microservice backend path

this file contains routers for microservices

5: Set as startup project: OcletAPIGateway

run this project try to use "UpstreamPathTemplate" url from ocelot.json file

