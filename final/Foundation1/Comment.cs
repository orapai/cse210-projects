using System;

public class Comment
{
    public string _personName;
    public string _textComment;

    public string DipalyComment(Comment comments)
    {
        return $"{comments._personName}: {comments._textComment}";
    }

}