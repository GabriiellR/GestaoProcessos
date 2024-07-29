using GestaoProcesso.Aprensentacao.Enumeradores;
using GestaoProcessos.Infraestrutura.CrossCutting.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace GestaoProcesso.Aprensentacao.Constants
{
    public static class DefaultResults
    {
        public static ActionResult HandleResult(ResultType result)
        {
            switch (result)
            {
                case ResultType.Get:
                case ResultType.Post:
                case ResultType.Remove:
                    return new OkObjectResult(new ResultValue { Message = result.GetDescription() });

                case ResultType.ErrorGet:
                case ResultType.ErrorPost:
                case ResultType.ErrorRemove:
                    return new BadRequestObjectResult(new ResultValue { Message = result.GetDescription() });
            }
            throw new InvalidOperationException();
        }

        public static ActionResult HandleResult(ResultType resultType, object data)
        {
            switch (resultType)
            {
                case ResultType.Get:
                case ResultType.Post:
                case ResultType.Remove:
                    return new OkObjectResult(new ResultValue { Message = resultType.GetDescription(), Data = data });

                case ResultType.ErrorGet:
                case ResultType.ErrorPost:
                case ResultType.ErrorRemove:
                    return new BadRequestObjectResult(new ResultValue { Message = resultType.GetDescription(), Data = data });
            }

            throw new InvalidOperationException();
        }

        public static ActionResult HandleResult(string message)
        {
            return new OkObjectResult(new ResultValue { Message = message });
        }
    }
}
