import { defineConfig } from "vite";
import react from "@vitejs/plugin-react";
import { readFileSync } from "fs";
import { join } from "path";

const baseFolder =
    process.env.APPDATA !== undefined && process.env.APPDATA !== ""
        ? `${process.env.APPDATA}/ASP.NET/https`
        : `${process.env.HOME}/.aspnet/https`;

const certificateName = process.env.npm_package_name;

const certFilePath = join(baseFolder, `${certificateName}.pem`);
const keyFilePath = join(baseFolder, `${certificateName}.key`);

// https://vitejs.dev/config/
export default defineConfig({
    build: {
        outDir: "../api/wwwroot",
    },
    server: {
        https: {
            key: readFileSync(keyFilePath),
            cert: readFileSync(certFilePath),
        },
        proxy: {
            "/api": {
                target: "https://localhost:5000/",
                changeOrigin: true,
                secure: false,
            },
        },
    },
    plugins: [react()],
});
