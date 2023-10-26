export default async function fetchDataFromCamera() {
  const baseUrl = "http://192.168.0.160/ISAPI/System/Video/inputs/channels/1/counting/search";

  // const body = `<?xml version="1.0" encoding="UTF-8"?>
  // <CountingStatisticsDescription>
  //   <reportType>daily</reportType>
  //   <timeSpanList>
  //     <timeSpan>
  //       <startTime>2023-06-28T14:00:00</startTime>
  //       <endTime>2023-06-28T23:59:59</endTime>
  //     </timeSpan>
  //   </timeSpanList>
  // </CountingStatisticsDescription>`;

  const params = new URLSearchParams();
  params.append('reportType', 'daily');
  params.append('startTime', '2023-06-28T14:00:00');
  params.append('endTime', '2023-06-28T23:59:59');

  const headers = new Headers({
    Authorization: 'Basic' + btoa('Gilde:Roermond2023'),
    'Content-Type': 'application/xml'
  });
  console.log(headers);
  debugger;
  const url = `${baseUrl}?${params.toString()}`;

  
    const response = await fetch(url, {
      method: 'GET', // Use the appropriate HTTP method ('GET' in this case)
      headers, // Pass the headers object directly
    });
    
    try {
    if (response.ok) {
      const data = await response.json();
      return data;
    } else {
      throw new Error("Failed to retrieve data from the camera API");
    }
  } catch (error) {
    console.error("An error occurred:", error);
    throw error;
  }
}


  
      