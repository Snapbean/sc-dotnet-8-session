const string oneLineLiteral = """This is a "one" line literal""";
Console.WriteLine(oneLineLiteral);

const string multiLineLiteral = """
            This is a "multi" line literal
                Spaces included in this line.          And also here.
            The space on the left side of this line is not included.
            Compilation error when spaces don't match.
            """;
Console.WriteLine(multiLineLiteral);

const string firstName = "John";
const string lastName = "Doe";
const string fullName = $$"""
            FullName: {{{firstName}}} {{{lastName}}}
            """;
Console.WriteLine(fullName);

const string json = $$"""
    [
        {
            "firstName": "{{firstName}}",
            "lastName": "{{lastName}}"
        }
    ]
    """;
Console.WriteLine(json);