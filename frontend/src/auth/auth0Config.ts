import { createAuth0 } from '@auth0/auth0-vue';

export const auth0Plugin = createAuth0({
  domain: import.meta.env.VITE_AUTH0_DOMAIN,
  clientId: import.meta.env.VITE_AUTH0_CLIENT_ID,
  authorizationParams: {
    redirect_uri: window.location.origin,
    audience: import.meta.env.VITE_AUTH0_AUDIENCE,
  },
  cacheLocation: 'localstorage',
  useRefreshTokens: true,
});
