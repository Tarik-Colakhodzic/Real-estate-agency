using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealEstateAgency.Model;
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
        public PaymentController()
        {
        }

        private Token stripeToken;
        private TokenService Tokenservice;

        private string StripePublishableApiKey = "pk_test_51KHCfLKRDUcIdarPfWjv1ZqwVDuKGgtd4bYviOunkt7XhtCLraqnotJenARYF733rIGY87lHizALkgdQ3i17zi5S00OumoDJjK";
        private string StripeSecretApiKey = "sk_test_51KHCfLKRDUcIdarPZRvw4oXWN2CxEaUkbvynLqsI74RJXtIK5gtgrioWFAXM0zPgTxlnRlpgaMyGb59oTn5x6xW100FocD0BTS";

        public bool IsTransactionSuccess { get; set; }

        [HttpPost]
        [Route("ProccessPayment")]
        public async Task ProccessPayment(CreditCard creditCard)
        {
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;
            try
            {
                await Task.Run(() =>
                {
                    var Token = CreateToken(creditCard);
                    if (Token != null)
                        IsTransactionSuccess = MakePayment(Token);
                });
            }
            catch (Exception ex)
            {
            }
            finally
            {
                if (IsTransactionSuccess)
                {
                }
            }
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
                        //Name = "Tarik Čolakhodžić",
                        //AddressLine1 = "18",
                        AddressLine2 = "SpringBoard",
                        AddressCity = "Gurgoan",
                        AddressZip = "284005",
                        //AddressState = "Mostar",
                        //AddressCountry = "Bosnia and Herzegovina",
                        Currency = "bam",
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

        private bool MakePayment(string token)
        {
            try
            {
                StripeConfiguration.SetApiKey(StripeSecretApiKey);
                var options = new ChargeCreateOptions
                {
                    Amount = (long)float.Parse("20000"),
                    Currency = "bam",
                    Description = "Charge for john.doe@example.com",
                    Source = stripeToken.Id,
                    StatementDescriptor = "Custom descriptor",
                    Capture = true,
                    ReceiptEmail = "tarikcolakhodzic@gmail.com",
                };

                //Make Payment
                var service = new ChargeService();
                Charge charge = service.Create(options);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}