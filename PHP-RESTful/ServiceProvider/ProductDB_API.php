<?php
//header("Content-type: application/json");
include('class_lib/ProductDB.php');

$productName = $_REQUEST['product'];

$productDB = new ProductDB();
$rProduct = $productDB->getProduct($productName);

$data = array();
$data['productString'] = $rProduct->toString();
$data['productCode'] = $rProduct->getCode();
$data['productDescription'] = $rProduct->getDescription();
$data['productPrice'] = $rProduct->getPrice();

print(json_encode($data));

?>