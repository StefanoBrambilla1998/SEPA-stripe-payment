﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SEPA_stripe_payment
{
    public class StripeController : Controller
    {
        [HttpGet]
        public IActionResult GetPaymentElement()
        {
            return (IActionResult)View();
        }
    }
}