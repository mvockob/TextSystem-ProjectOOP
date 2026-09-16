using TextSystem;

// Same scenario as the original assignment demo,
// but the document is assembled through the unified builder API.
Console.WriteLine("========== TEXT SYSTEM ==========\n");

DocumentBuilder builder = new();
builder
    .AddHeading(1, "Object-Oriented Programming")
    .AddParagraph("OOP is a programming paradigm based on the concept of objects.")
    .AddHeading(2, "Core Principles")
    .AddParagraph("The four pillars are Encapsulation, Abstraction, Inheritance, and Polymorphism.")
    .AddLink("Read more here", "https://docs.microsoft.com/dotnet/csharp/fundamentals/tutorials/oop")
    .MoveElement(4, 3);

TextDocument document = builder.Build();

Console.WriteLine(document.RenderTableOfContents());
Console.WriteLine("--- Rendered Document ---");
Console.WriteLine(document.RenderDocument());
