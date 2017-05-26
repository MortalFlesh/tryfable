namespace tryfable

module test =
    type Person(name:string, age:int) =
        let mutable _age = age

        new (name:string) = Person(name, 0)

        member this.Name = name
        member this.Age
            with get() = _age
            and set(value) = _age <- value

        member this.HasBirthday() = _age <- _age + 1
        member this.IsOlderThan age = _age >= age

        override this.ToString() =
            "Name: " + name + ", Age: " + (string)_age

    // testing Person
    let mortalek = Person("Mortalek", 27)

    printf "Name: %s" mortalek.Name
