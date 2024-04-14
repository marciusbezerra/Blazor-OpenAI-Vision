
namespace vision_test.Models
{
    public class VisionPayloadModel
    {
        public string? Model { get; set; } // gpt-4-turbo
        public List<PayloadMessage> Messages { get; set; } = new();
    }

    public class PayloadMessage
    {
        public string? Role { get; set; } // user or assistant
        public List<PayloadContent> Content { get; set; } = new();
    }

    public class PayloadContent
    {
        public string? Type { get; set; } // text or image_url
        public string? Text { get; set; }
        public ImageUrl? Image_url { get; set; }
    }

    public class ImageUrl
    {
        public string? Url { get; set; }
    }
}