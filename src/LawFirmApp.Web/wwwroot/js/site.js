document.addEventListener("submit", (event) => {
    const form = event.target;

    if (!form.matches(".intake-form, .stacked-form")) {
        return;
    }

    event.preventDefault();

    const existing = form.querySelector(".form-status");
    if (existing) {
        existing.remove();
    }

    const status = document.createElement("p");
    status.className = "form-status";
    status.textContent = "Prototype submission captured. Connect this form to the API endpoint before production.";
    form.appendChild(status);
});
