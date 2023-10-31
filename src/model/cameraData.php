<?php
$baseUrl = "http://192.168.0.160/ISAPI/System/Video/inputs/channels/1/counting/search";

// Query parameters
$params = array(
    'reportType' => 'daily',
    'startTime' => '2023-06-28T14:00:00',
    'endTime' => '2023-06-28T23:59:59'
);

// Construct the URL with query parameters
$url = $baseUrl . '?' . http_build_query($params);

// Authorization header (Basic Authentication)
$username = 'Gilde';
$password = 'Roermond2023';
$auth = base64_encode($username . ':' . $password);

// Create cURL resource
$ch = curl_init($url);

// Set cURL options
curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);
curl_setopt($ch, CURLOPT_HTTPHEADER, array(
    'Authorization: Basic ' . $auth,
    'Content-Type: application/xml'
));

// Execute the cURL request
$response = curl_exec($ch);

if ($response === false) {
    // cURL error occurred
    echo "cURL Error: " . curl_error($ch);
} else {
    // cURL request was successful, and $response contains the response data
    echo "Response: " . $response;
}

// Close cURL resource
curl_close($ch);
?>
