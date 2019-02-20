class NoregCli < Formula
    desc "Deploy machine learning with confidence."
    homepage "https://github.com/JasonTheDeveloper/NoRegressions"
    url "https://github.com/JasonTheDeveloper/NoRegressions/releases/download/v0.0.3-mac/noreg-osx-x64.tar.gz"
    sha256 "11cf954ce0abf085706953cfc66f786cba3da4ae9ff7f6de8a82ca640ae6eaa9"
  
    def install
        mv "./noreg-cli", "./noreg"
        bin.install Dir["./*"]
    end
    
    def post_install
        system "chmod -R 666 #{bin}/configsettings.json"
    end
  
    test do
        system "false"
    end
end

__END__
