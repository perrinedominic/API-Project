terraform {
  required_providers {
    aws = {
        source = "hashicorp/aws"
        version = ">= 5.65.0"
        region = "us-east-1"
    }
  }
}