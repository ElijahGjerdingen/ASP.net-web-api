var url = "https://localhost:44348/players";
var playersList = document.getElementById("players-list");

if (playersList) {
    fetch(url)
        .then(response => response.json())
        .then(data => showPlayers(data))
        .catch(ex => {
            alert("something went wrong ... ");
            console.log(ex);
        });
}
function showPlayers(players) {
    players.forEach(player => {
        let li = document.createElement("li");
        let text = `${player.name} ($${player.price})`;
        li.appendChild(document.createTextNode(text));
        playersList.appendChild(li);
    });
}