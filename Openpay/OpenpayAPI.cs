﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Openpay
{
    public class OpenpayAPI
    {
        public CustomerService CustomerService { get; internal set; }

        public CardService CardService { get; internal set; }

        public PseService PseService { get; internal set; }

        public ChargeService ChargeService { get; internal set; }

		public PayoutReportService PayoutReportService { get; internal set; }

        public TransferService TransferService { get; internal set; }

        public PayoutService PayoutService { get; internal set; }

        public FeeService FeeService { get; internal set; }

        public PlanService PlanService { get; internal set; }

        public SubscriptionService SubscriptionService { get; internal set; }

		public OpenpayFeesService OpenpayFeesService { get; internal set; }

		public WebhookService WebhooksService { get; set; }

        public MerchantService MerchantService { get; set; }

        private OpenpayHttpClient httpClient;

        public OpenpayAPI( string api_key, string merchant_id,bool production = false)
        {
            this.httpClient = new OpenpayHttpClient(api_key, merchant_id, production);
            CustomerService = new CustomerService(this.httpClient);
            CardService = new CardService(this.httpClient);
            PseService = new PseService(this.httpClient);
            ChargeService = new ChargeService(this.httpClient);
            PayoutService = new PayoutService(this.httpClient);
            TransferService = new TransferService(this.httpClient);
            FeeService = new FeeService(this.httpClient);
            PlanService = new PlanService(this.httpClient);
            SubscriptionService = new SubscriptionService(this.httpClient);
			OpenpayFeesService = new OpenpayFeesService(this.httpClient);
			WebhooksService = new WebhookService (this.httpClient);
			PayoutReportService = new PayoutReportService (this.httpClient);
            MerchantService = new MerchantService (this.httpClient);
        }

        public bool Production {
            get
            {
                return this.httpClient.Production;
            }
            set
            {
                this.httpClient.Production = value;
            }
        }
    }
}
