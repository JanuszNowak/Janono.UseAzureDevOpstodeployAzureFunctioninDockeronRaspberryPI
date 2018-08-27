docker build -t azurefunctionlinux .
docker run -p 8080:80 -it azurefunctionlinux  

docker tag azurefunctionlinux janono/azurefunctionlinux
docker push janono/azurefunctionlinux
docker pull janono/azurefunctionlinux
#docker version
#docker update
#docker ps 

#docker stop $(docker ps -a -q)
#docker rm $(docker ps -a -q)
# Delete all images
#docker rmi $(docker images -q)
#