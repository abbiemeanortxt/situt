private static async Task<string> GenRandNames(int numWords)
{
    // Predefined lists of first and last parts of the names
    var firstParts = new List<string> { "Bright", "Dark", "Silent", "Thunder", "Swift" };
    var lastParts = new List<string> { "Forest", "River", "Mountain", "Sky", "Flame" };

    // Use a StringBuilder for efficient string concatenation
    var stringBuilder = new StringBuilder();

    // Random number generator
    var random = new Random();

    // Generate each name and append it to the StringBuilder
    for (int i = 0; i < numWords; i++)
    {
        // Select random parts from the lists
        var firstNamePart = firstParts[random.Next(firstParts.Count)];
        var lastNamePart = lastParts[random.Next(lastParts.Count)];

        // Combine the parts to form a name
        var name = $"{firstNamePart}{lastNamePart}";

        // Append the name to the StringBuilder, followed by a comma if it's not the last name
        stringBuilder.Append(name);
        if (i < numWords - 1)
        {
            stringBuilder.Append(", ");
        }
    }

    // Return the concatenated string of names
    return await Task.FromResult(stringBuilder.ToString());
}
