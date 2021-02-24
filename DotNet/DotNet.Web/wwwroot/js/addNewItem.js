(function () {
    const alertElement = document.getElementById("success-alert");
    const formElement = document.forms[0];
    const addNewItem = async () => {
        const requestData = JSON.stringify({
            Name: document.getElementById("Name").value,
            Description: document.getElementById("Description").value,
            IsVisible: document.getElementById("IsVisible").checked
        });
        const response = await fetch('/api/CompanyAsync/AddNewItem', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: requestData
        });
        const responseJson = await response.json();
        if (responseJson.success) {
            alertElement.style.display = "";
        }
    };
    window.addEventListener("load", () => {
        formElement.addEventListener("submit", event => {
            event.preventDefault();
            alertElement.style.display = "none";
            addNewItem().then(() => console.log("added successfully"));
        });
    });
})();