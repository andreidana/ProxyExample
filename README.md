# ProxyExample

**Definition** 
Provide a surrogate or placeholder for another object to control access to it. 

**Applicability**
Proxy is applicable whenever there is a need for a more versatile or sophisticated reference to an object than a simple pointer. Here are several common situations in which the Proxy pattern is applicable: 

 - A remote proxy provides a local representative for an object in a different address space.  
 - A virtual proxy creates expensive objects on demand.
 - A protection proxy controls access to the original object. Protection proxies are useful when objects should have different access rights.  
 - A smart reference is a replacement for a bare pointer that performs additional actions when an object is accessed. Typical uses include:  
 	- counting the number of references to the real object so that it can be freed automatically when there are no more references.  
 	- loading a persistent object into memory when it's first referenced.  
 	- checking that the real object is locked before it's accessed to ensure that no other object can change it.  

**Consequences**

 - A remote proxy can hide the fact that an object resides in a different address space.  
 - A virtual proxy can perform optimizations such as creating an object on demand.  
 - Both protection proxies and smart references allow additional housekeeping tasks when an object is accessed.  

**Related Patterns**

- [Adapter](https://github.com/andreidana/AdapterPattern)
- [Decorator](https://github.com/andreidana/DecoratorPattern)