const ENV = {
  dev: {
    apiUrl: 'http://localhost:44380',
    oAuthConfig: {
      issuer: 'http://localhost:44380',
      clientId: 'AbpFirstProject_App',
      clientSecret: '1q2w3e*',
      scope: 'AbpFirstProject',
    },
    localization: {
      defaultResourceName: 'AbpFirstProject',
    },
  },
  prod: {
    apiUrl: 'http://localhost:44380',
    oAuthConfig: {
      issuer: 'http://localhost:44380',
      clientId: 'AbpFirstProject_App',
      clientSecret: '1q2w3e*',
      scope: 'AbpFirstProject',
    },
    localization: {
      defaultResourceName: 'AbpFirstProject',
    },
  },
};

export const getEnvVars = () => {
  // eslint-disable-next-line no-undef
  return __DEV__ ? ENV.dev : ENV.prod;
};
