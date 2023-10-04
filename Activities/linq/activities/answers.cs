public List<string> FilterStringsStartingWithA(List<string> inputList)
{
    return inputList.Where(s => s.StartsWith("A")).ToList();
}