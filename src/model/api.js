async function logData () {
   const response = fetch("http://192.168.0.160/ISAPI/System/Video/inputs/channels/1/counting/search");

   const movies = await response.json();
   console.log(movies);
}





