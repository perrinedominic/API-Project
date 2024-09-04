module "ecr_repo" {
  source = "../../../Modules/ECR"
  ecr_name = "dev-api"
}