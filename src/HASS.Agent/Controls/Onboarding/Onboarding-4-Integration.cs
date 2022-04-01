﻿using HASS.Agent.Functions;

namespace HASS.Agent.Controls.Onboarding
{
    public partial class OnboardingIntegration : UserControl
    {
        public OnboardingIntegration()
        {
            InitializeComponent();
        }

        private void OnboardingIntegration_Load(object sender, EventArgs e)
        {
            //
        }

        private void LblIntegration_Click(object sender, EventArgs e) => HelperFunctions.LaunchUrl("https://github.com/LAB02-Research/HASS.Agent-Notifier");
    }
}