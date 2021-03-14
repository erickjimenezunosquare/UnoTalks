using System;
namespace Framework
{
    public interface IPage
    {
        void InitElements();

        Browser Browser { get; set; }
    }
}
