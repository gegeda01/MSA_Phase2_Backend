# MSA_Phase2_Backend

**Section Two**

Demonstrate an understanding of how these middleware via DI (dependency injection) simplifies your code:

The purpose of dependency injection is to make a class independent of its dependencies. It helps organize the project's code and provides
an easy way to change implementations. This can also help middleware to resolve their dependencies. For example, this is used when we are using 
Swagger for our configuration. It registers the Swagger middleware with optional setup action for DI-injected options.

**Section Three**

Demonstrate an understanding of why the middleware libraries made your code easier to test:

Making use of middleware, it allows me to it can instantiate the app pipeline containing only the components that I want to test. I can test through sending custom requests. Advantages like exceptions in the middleware can flow directly back to the calling test is also noticable during the unit testing.

