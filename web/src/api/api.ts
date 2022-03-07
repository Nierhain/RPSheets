import { GetTokenSilentlyOptions } from "@auth0/auth0-react";
import axios, { Axios, AxiosResponse } from "axios";

const tokenKey = "acces_token";
const instance = axios.create({
    baseURL: "/api/",
    headers: { authorization: `Bearer ${localStorage.getItem(tokenKey)}` },
});

const authURL = "https://rpsheets.eu.auth0.com/api/v2/";
const scope = "Admin Gamemaster Player";
const responseBody = (response: AxiosResponse) => response.data;

const requests = {
    get: (url: string) => instance.get(url).then(responseBody),
    post: (url: string, body: any) => instance.post(url).then(responseBody),
    put: (url: string, body: any) => instance.put(url).then(responseBody),
    delete: (url: string) => instance.delete(url).then(responseBody),
};

export const UserAPI = {
    login: async (
        getAccessToken: (options: GetTokenSilentlyOptions) => Promise<string>
    ) => {
        const accessToken = await getAccessToken({
            audience: "api",
            scope: "Player",
        });
        localStorage.setItem(tokenKey, accessToken);
    },
};

export const SheetAPI = {};
