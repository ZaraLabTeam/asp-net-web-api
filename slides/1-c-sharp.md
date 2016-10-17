## Brief history of C# #

* Family: **C** <!-- .element class="text-success" -->
* Developed and designed by Microsoft
* Platform: Common Language Infrastructure
* Filename extension: **.cs** <!-- .element class="text-success" -->
* Webpage: https://www.visualstudio.com/


### Object Oriented

```C#
namespace SchoolSystem.DataModels.Abstraction
{
    using System;
    using System.Text.RegularExpressions;
    using static Constraints;

    public abstract class Person : IEntity
    {
        protected Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.ValidateParameters();
        }

        public string FirstName { get; }

        public string LastName { get; }

        public int Id { get; private set; }

        public void SetId(int id)
        {
            this.Id = id;
        }

        private void ValidateParameters()
        {
            var patern = new Regex(NamePattern);

            if (this.IsOutOfRange(this.FirstName) || patern.IsMatch(this.FirstName) == false)
            {
                throw new ArgumentException("First Name is invalid");
            }

            if (this.IsOutOfRange(this.LastName) || patern.IsMatch(this.LastName) == false)
            {
                throw new ArgumentException("Last Name is invalid");
            }
        }

        private bool IsOutOfRange(string name)
        {
            return name.Length < MinNameLength || name.Length > MaxNameLength;
        }
    }
}
```
<!-- .element class="code code-large" -->


<!-- .element style="text-align: left" -->
### OO Basics

* Abstraction
* Encapsulation
* Polymorphism
* Inheritance

Notes:
Using classes polymorphically, what is inheritance, 
design by contract and how encapsulation work


<!-- .element style="text-align: right" -->
### OO Principles

* Encapsulate what varies
* Favor composition over inheritance
* Program to interfaces, not implementations
* And many more...


<!-- .element style="text-align: left" -->
### What's the one thing you can always count on in software development?

<q>
No matter where you work, what you're building, or what language you
are programming in, whats the one true constant that will be with you
always?
</q>

# CHANGE 
<!-- .element class="fragment fade-right" style="color: #1b91ff" -->

<q class="fragment">
No matter how well you design an application, over time an
application will grow and change.
</q>

\# quoted from 
<!-- .element class="fragment" style="text-align: right" --> 
"*Head First Design Patterns*" <!-- .element class="text-info" -->
