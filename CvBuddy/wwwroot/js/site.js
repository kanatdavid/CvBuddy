//Hämta notification HTML elementet som ska hanteras
const notification = document.getElementById("notification");

//Eventlyssnare som lyssnar på när domänen laddas om(när sidan refreshas på något sätt)
document.addEventListener("DOMContentLoaded", function () {
    ShowNotification();//Funktionen anropas då
});

//Funktionen som anropas
function ShowNotification() {
    const notReadCount = Number(notification.textContent)//parsear elementets text innehåll till ett nummer
    if (notReadCount > 0) {
        notification.classList.add("notification-container");//lägg till till styling för elemetet
    } else {
        notification.textContent = "";//tömm elementets text innehåll
        notification.classList.remove("notification-container");//ta bort styling, eftersom padding används, då när text innehållet är "" så syns elementets styling ändå, därför tas den bort när den inte har något innehåll, då syns inget
    }
}