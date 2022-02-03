using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealEstateAgency.Model;
using RealEstateAgency.Services;
using Stripe;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace RealEstateAgency.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentController : ControllerBase
    {
        public PaymentController(IPropertyService propertyService)
        {
            _propertyService = propertyService;
        }

        private Token stripeToken;
        private TokenService Tokenservice;

        private string StripePublishableApiKey = "pk_test_51KHCfLKRDUcIdarPfWjv1ZqwVDuKGgtd4bYviOunkt7XhtCLraqnotJenARYF733rIGY87lHizALkgdQ3i17zi5S00OumoDJjK";
        private string StripeSecretApiKey = "sk_test_51KHCfLKRDUcIdarPZRvw4oXWN2CxEaUkbvynLqsI74RJXtIK5gtgrioWFAXM0zPgTxlnRlpgaMyGb59oTn5x6xW100FocD0BTS";
        private IPropertyService _propertyService;

        public bool IsTransactionSuccess { get; set; }

        [HttpPost]
        [Route("ProccessPayment")]
        public async Task<IActionResult> ProccessPayment(CreditCard creditCard)
        {
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;
            try
            {
                await Task.Run(() =>
                {
                    var Token = CreateToken(creditCard);
                    if (Token != null)
                        IsTransactionSuccess = MakePayment(Token, creditCard.Amount, creditCard.Currency, creditCard.PropertyId);
                });
                if (IsTransactionSuccess)
                {
                    return Ok();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
            return StatusCode(500);
        }

        private string CreateToken(CreditCard creditCard)
        {
            try
            {
                StripeConfiguration.SetApiKey(StripePublishableApiKey);
                var service = new ChargeService();

                var tokenOptions = new TokenCreateOptions
                {
                    Card = new TokenCardOptions
                    {
                        Number = creditCard.Number,
                        ExpYear = creditCard.ExpYear,
                        ExpMonth = creditCard.ExpMonth,
                        Cvc = creditCard.Cvc,
                        Name = creditCard.Name,
                        AddressState = creditCard.AddressState,
                        AddressCountry = creditCard.AddressCountry,
                        AddressLine1 = creditCard.AddressLine1,
                        Currency = creditCard.Currency,
                        AddressLine2 = "SpringBoard",
                        AddressCity = "Gurgoan",
                        AddressZip = "284005",
                    }
                };

                Tokenservice = new TokenService();
                stripeToken = Tokenservice.Create(tokenOptions);
                return stripeToken.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool MakePayment(string token, long? amount, string currency, int propertyId)
        {
            try
            {
                StripeConfiguration.SetApiKey(StripeSecretApiKey);
                var options = new ChargeCreateOptions
                {
                    Amount = amount,
                    Currency = currency,
                    Description = "Charge for john.doe@example.com",
                    Source = stripeToken.Id,
                    StatementDescriptor = "Custom descriptor",
                    Capture = true,
                    ReceiptEmail = "tarikcolakhodzic@gmail.com",
                };

                //Make Payment
                var service = new ChargeService();
                Charge charge = service.Create(options);
                _propertyService.SetPaid(propertyId, true, charge.Id);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> GetCharges()
        {
            StripeConfiguration.SetApiKey(StripeSecretApiKey);
            var service = new ChargeService();
            ChargeListOptions options = new ChargeListOptions();
            //Maksimalan broj koji Api vraća
            options.Limit = 100;
            var response = await service.ListAsync(options);
            return Ok(response);
        }
    }
}