FROM nginx

COPY www /usr/share/nginx/html
COPY nginx.conf /etc/nginx/nginx.conf
COPY ./certs/ /etc/ssl/

EXPOSE 80
EXPOSE 443
# To run the the image use
# docker run --name some-nginx -d -p 8080:80 some-content-nginx
