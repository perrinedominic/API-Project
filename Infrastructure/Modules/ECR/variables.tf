variable "ecr_name" {
    description = "The name of the ECR Repo"
    type = string
}

variable "region" {
  description = "The AWS region for provisioning resources."
  type = string
  default = "us-east-1"
}

variable "image_tag_mutability" {
  default = "IMMUTABLE"
}