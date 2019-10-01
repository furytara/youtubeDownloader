Write-Output "--- Execute in build.ps1";

if (${Env:BUILD_EXIT} -eq 1) {
	Write-Output "--- Build failure";
	throw "Build Failed. see log err for details";
}

Write-Output "--- Build success";

