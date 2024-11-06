using System.Text.Json;
using System.Text.Json.Serialization;

namespace UniversalTextParser;
public readonly struct ParserJob
{
    public readonly string Name;
    public readonly Target[] Targets;
    public readonly Step[] Steps;

    [JsonConstructor]
    public ParserJob(string name, Target[] targets, Step[] steps) =>
        (Name, Targets, Steps) = (name, targets, steps);
}

public readonly struct Target
{
    public readonly bool Recursive;
    public readonly string DirectoryPath;

    [JsonConstructor]
    public Target(bool recursive, string directoryPath) =>
        (Recursive, DirectoryPath) = (recursive, directoryPath);
}

public readonly struct Step
{
    public readonly string Keyword;
    public readonly string RegexString;

    [JsonConstructor]
    public Step(string keyword, string regexString) =>
        (Keyword, RegexString) = (keyword, regexString);
}