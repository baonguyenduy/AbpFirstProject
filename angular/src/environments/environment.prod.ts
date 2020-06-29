export const environment = {
  production: true,
  application: {
    name: 'AbpFirstProject',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44380',
    clientId: 'AbpFirstProject_App',
    dummyClientSecret: '1q2w3e*',
    scope: 'AbpFirstProject',
    showDebugInformation: true,
    oidc: false,
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44380',
    },
  },
  localization: {
    defaultResourceName: 'AbpFirstProject',
  },
};
