
namespace vision_test.Models;

public class VisionResultModel
{
    public Choice[]? Choices { get; set; }
    public ResponseError? Error { get; set; }
}

public class Choice
{
    public MessageContent? Message { get; set; }
}

public class MessageContent
{
    public string? Content { get; set; }
}

public class ResponseError
{
    public string? Message { get; set; }
}