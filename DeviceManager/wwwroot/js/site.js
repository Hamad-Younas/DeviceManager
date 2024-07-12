export function setTheme(themeName) {
    // Create a new link element
    let newLink = document.createElement("link");
    newLink.setAttribute("rel", "stylesheet");
    newLink.setAttribute("type", "text/css");
    newLink.setAttribute("href", `css/app-${themeName}.css`);

    // Remove and replace the theme
    let head = document.head;
    let existingLink = head.querySelector("#theme");

    if (existingLink) {
        head.removeChild(existingLink);
    }

    head.appendChild(newLink);
    console.log(`Theme set to: ${themeName}`);
}




