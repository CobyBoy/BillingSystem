using BillingSystem.Enums;
using BillingSystem.Models;
using BillingSystem.Services;

namespace UnitTests
{
    public class BillingSystemTest
    {
        private CallService _callService;

        [SetUp]
        public void Setup()
        {
            _callService = new CallService();
        }

        [Test]
        public void ShouldCalculateCostForARegularAndNationalCallForNewClient()
        {
            Client client = new Client(ClientType.NEW);
            DateTime StartTime = DateTime.Now;
            DateTime EndTime = DateTime.Now.AddMinutes(1.00);
            Call call = new Call(client, RateType.REGULAR, CallType.NATIONAL, StartTime, EndTime);
            call.GetCallCost();
            Assert.That(call.GetCallCost(), Is.EqualTo(0.02));
        }

        [Test]
        public void ShouldCalculateCostForARegularAndInternacionalCallForNewClient()
        {
            Client client = new Client(ClientType.NEW);
            DateTime StartTime = DateTime.Now;
            DateTime EndTime = DateTime.Now.AddMinutes(1.00);
            Call call = new Call(client, RateType.REGULAR, CallType.INTERNATIONAL, StartTime, EndTime);
            call.GetCallCost();
            Assert.That(call.GetCallCost(), Is.EqualTo(0.04));
        }

        [Test]
        public void ShouldCalculateCostForARegularAndNationalCallForExistingClient()
        {
            Client client = new Client(ClientType.EXISTING);
            DateTime StartTime = DateTime.Now;
            DateTime EndTime = DateTime.Now.AddMinutes(1441.00);
            Call call = new Call(client, RateType.REGULAR, CallType.NATIONAL, StartTime, EndTime);
            call.GetCallCost();
            Assert.That(call.GetCallCost(), Is.EqualTo(72.05));
        }


        [Test]
        public void ShouldCreateToCallHistory()
        {
            Client client = new Client(ClientType.EXISTING);
            DateTime StartTime = DateTime.Now;
            DateTime EndTime = DateTime.Now.AddMinutes(3);
            Call call = new Call(client, RateType.REGULAR, CallType.INTERNATIONAL, StartTime, EndTime);
            Call call2 = new Call(client, RateType.WEEKEND, CallType.NATIONAL, StartTime, EndTime);
            call.GetCallCost();
            _callService.AddCallToCallHistory(call);
            _callService.AddCallToCallHistory(call2);
            _callService.AddCallToCallHistory(null);

            Assert.That(_callService.GetCallHistory().Count, Is.EqualTo(2));
        }

        [Test]
        public void ShouldCalculateBillingCost()
        {
            Client client = new Client(ClientType.EXISTING);
            DateTime StartTime = DateTime.Now;
            DateTime EndTime = DateTime.Now.AddMinutes(3);
            Call call = new Call(client, RateType.REGULAR, CallType.INTERNATIONAL, StartTime, EndTime);
            Call call2 = new Call(client, RateType.WEEKEND, CallType.NATIONAL, StartTime, EndTime);
            _callService.AddCallToCallHistory(call);
            _callService.AddCallToCallHistory(call2);
            _callService.AddCallToCallHistory(null);

            Assert.That(BillingService.CalculateBill(_callService.GetCallHistory()), Is.EqualTo(0.33));
        }
    }
}