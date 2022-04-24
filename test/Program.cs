// See https://aka.ms/new-console-template for more information




using RegexBuilder;

var builder = new Builder();

builder.Group(i => {
    i.Contains("cat", "dog");

});

builder.StringLiteral(" ");
builder.Group(i => {
    i.Contains("cat1", "dog1");
    i.StringLiteral(" ");
    i.Group(i => {
        i.Contains("cat2", "dog2");
    })
    .Count(15);

});

builder.CharacterClass(RegexConst.AZaz);
builder.Count(10);
builder.StringLiteral(" ");

builder.CharacterClass(i => {
    i.StringLiteral(RegexConst.AZaz);
    i.Count(10);
});

builder.Group(i => {

    i.CharacterClass(i => {
        i.StringLiteral(RegexConst.AZaz);
        i.Count(10);
    });
    
});


Console.WriteLine(builder.Build(true));
