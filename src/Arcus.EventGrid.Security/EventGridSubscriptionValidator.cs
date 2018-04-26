﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using System.Configuration;

namespace Arcus.EventGrid.Security
{
    public class EventGridSubscriptionValidator : ActionFilterAttribute
    {
        public override async Task OnActionExecutingAsync(HttpActionContext actionContext, CancellationToken cancellationToken)
        {
            try
            {
                if (actionContext.Request.Headers.TryGetValues("Aeg-Event-Type", out IEnumerable<string> headerValues))
                {
                    //TODO : add logging
                    //Log.Logger.Information("Subscription validation message received by Action Filter");
                    if (headerValues.Contains("SubscriptionValidation"))
                    {
                        var gridMessage = EventGridMessage<SubscriptionEventData>.Parse(await actionContext.Request.Content.ReadAsStringAsync());
                        var validationCode = gridMessage?.Events?[0]?.Data?.ValidationCode;
                        if (validationCode != null)
                        {
                            // This is a subscription validation message, echo the validationCode
                            actionContext.Response = actionContext.Request.CreateResponse(
                                HttpStatusCode.OK,
                                new { validationResponse = validationCode.ToString() },
                                new JsonMediaTypeFormatter()
                            );
                            //TODO : add logging
                            //Log.Logger.Information("Echoing back the validation code {validationCode}", validationCode.ToString());

                            return;
                        }
                    }
                }
                // When arriving here, the message was not a validation message, so let it handle by the pipeline
                await base.OnActionExecutingAsync(actionContext, cancellationToken);
            }
            catch (Exception e)
            {
                //TODO : add logging
                //Log.Logger.Error(e, "error in filter");
                await base.OnActionExecutingAsync(actionContext, cancellationToken);
            }
        }

        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {

        }
    }
}