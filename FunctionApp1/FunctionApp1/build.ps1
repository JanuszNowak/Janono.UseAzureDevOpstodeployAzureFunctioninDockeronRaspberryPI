docker build -t azurefunctionlinux .
docker run -p 8080:80 -it azurefunctionlinux  

docker tag azurefunctionlinux janono/azurefunctionlinux
docker login
docker push janono/azurefunctionlinux

#docker version
#docker update
#docker ps 

docker stop $(docker ps -a -q)
docker rm $(docker ps -a -q)
# Delete all images
docker rmi $(docker images -q)
docker ps
docker images
#




docker build -f Dockerfile.RPi3 -t azurefunctionlinuxrpi3 .
docker run -p 8080:80 -it azurefunctionlinuxrpi3  

docker tag azurefunctionlinuxrpi3 janono/azurefunctionlinuxrpi3
docker login
docker push janono/azurefunctionlinuxrpi3

docker images

#https://hub.docker.com/r/microsoft/azure-functions-runtime/tags/