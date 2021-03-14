using System;
namespace Framework
{
    public interface IPage
    {
        void InitElements();

        void GoTo();

        Browser Browser { get; set; }
    }
}
