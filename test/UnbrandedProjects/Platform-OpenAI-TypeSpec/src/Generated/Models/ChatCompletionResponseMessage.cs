// <auto-generated/>

#nullable disable

namespace OpenAI.Models
{
    /// <summary> The ChatCompletionResponseMessage. </summary>
    public partial class ChatCompletionResponseMessage
    {
        /// <summary> Initializes a new instance of ChatCompletionResponseMessage. </summary>
        /// <param name="role"> The role of the author of this message. </param>
        /// <param name="content"> The contents of the message. </param>
        internal ChatCompletionResponseMessage(ChatCompletionResponseMessageRole role, string content)
        {
            Role = role;
            Content = content;
        }

        /// <summary> Initializes a new instance of ChatCompletionResponseMessage. </summary>
        /// <param name="role"> The role of the author of this message. </param>
        /// <param name="content"> The contents of the message. </param>
        /// <param name="functionCall"> The name and arguments of a function that should be called, as generated by the model. </param>
        internal ChatCompletionResponseMessage(ChatCompletionResponseMessageRole role, string content, CreateChatCompletionResponseFunctionCall functionCall)
        {
            Role = role;
            Content = content;
            FunctionCall = functionCall;
        }

        /// <summary> The role of the author of this message. </summary>
        public ChatCompletionResponseMessageRole Role { get; }
        /// <summary> The contents of the message. </summary>
        public string Content { get; }
        /// <summary> The name and arguments of a function that should be called, as generated by the model. </summary>
        public CreateChatCompletionResponseFunctionCall FunctionCall { get; }
    }
}