# UniversalAPI

Collection of API hosted in heroku container using docker. A central API for all future proj dev. DB hosted in Mongo DB[Cloud].

Follow below link for proper working steps.

https://adevtalks.com/programming/create-a-net-core-api-and-add-docker-support-using-vs-code/
https://adevtalks.com/programming/deployment/deploy-net-core-3-1-web-api-to-heroku/

Use below links for guidance.

https://www.youtube.com/watch?v=gQMT4al2Grg

To deploy whenevr you comit in github, add heroku.yml file and add below config.
build:
  docker:
    web: Dockerfile

If you don?t include a run section, Heroku uses the CMD specified in the Dockerfile.
https://devcenter.heroku.com/articles/build-docker-images-heroku-yml