using System;

namespace LedgerStudy.Cqrs.Response
{
    public abstract class DefaultResponse<T>
    {
        public T Response { get; set; }

        protected DefaultResponse(T response)
        {
            Response = response;
        }
    }
}