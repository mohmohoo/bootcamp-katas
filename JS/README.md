# TESTING WITH MOCHA - CHAI

## INSTALLATION

Install dependencies

```sh
npm install
```

Build the container:

```sh
docker build -t my_container/node-7 .
```

## RUN

Run the tests:

```sh
docker run -it -v $(pwd):/var/app my_container/node-7
                          ```
