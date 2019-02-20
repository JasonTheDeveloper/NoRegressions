class NoregCli < Formula
    desc "Deploy machine learning with confidence."
    homepage "https://github.com/JasonTheDeveloper/NoRegressions"
    url "https://github.com/JasonTheDeveloper/NoRegressions/releases/download/v0.0.3-mac/noreg-osx-x64.tar.gz"
    sha256 "548216d5584f7d290d23e86e8a34ea6e857bf7a09f1995e0c620cec1aa0f71fb"
  
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
