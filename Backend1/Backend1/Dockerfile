FROM microsoft/dotnet:sdk
WORKDIR /Backend1
COPY ./ ./

RUN dotnet restore
RUN dotnet build
RUN dotnet publish

ENV ASPNETCORE_URLS http://+:5000
EXPOSE 5000

RUN chmod +x ./entrypoint.sh
ENTRYPOINT [ "/bin/bash", "./entrypoint.sh" ]
