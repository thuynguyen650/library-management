/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ["./src/**/*.{html,ts}"],
  theme: {
    extend: {
      padding: {
        custom_sm: "14%",
        custom_md: "26%",
      },
    },
  },
  plugins: [],
};
