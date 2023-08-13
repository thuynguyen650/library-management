/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
    "./src/**/*.{html,ts}",
    "./node_modules/tw-elements/dist/js/**/*.js",
  ],
  theme: {
    extend: {
      padding: {
        custom_sm: "12%",
        custom_md: "22%",
      },
      height: {
        screen_exclude_header: "calc(100vh - 114px)",
      },
    },
  },
  plugins: [],
};
